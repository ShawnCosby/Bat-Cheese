using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BatCheese.Repository
{
    public abstract class WcfRepository<TService, TClient> : IDisposable, IWcfRepository<TService, TClient>
        where TClient : ClientBase<TService>
        where TService : class
    {
        private Lazy<TClient> lazyClient;


        protected WcfRepository(TClient client)
        {
            this.lazyClient = new Lazy<TClient>(() => client, LazyThreadSafetyMode.None);
        }

        protected WcfRepository(Func<TClient> clientInitFunc)
        {
            this.lazyClient = new Lazy<TClient>(clientInitFunc, LazyThreadSafetyMode.ExecutionAndPublication);
        }


        public TimeSpan Timeout
        {
            get
            {
                return this.lazyClient.Value.InnerChannel.OperationTimeout;
            }
            set
            {
                this.lazyClient.Value.InnerChannel.OperationTimeout = value;
            }
        }

        protected TClient Client
        {
            get
            {
                if (this.disposed)
                {
                    throw new ObjectDisposedException(nameof(WcfRepository<TService, TClient>));
                }

                return this.lazyClient.Value;
            }
        }


        #region IDisposable Support
        private bool disposed = false;

        protected void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    if (this.lazyClient.Value != null)
                    {
                        try
                        {
                            if (this.lazyClient.Value.State != CommunicationState.Faulted)
                            {
                                this.lazyClient.Value.Close();
                            }
                            else
                            {
                                this.lazyClient.Value.Abort();
                            }
                        }
                        catch (CommunicationException)
                        {
                            this.lazyClient.Value.Abort();
                        }
                        catch (TimeoutException)
                        {
                            this.lazyClient.Value.Abort();
                        }
                        catch
                        {
                            this.lazyClient.Value.Abort();

                            throw;
                        }
                    }
                }

                this.disposed = true;
            }
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
