﻿using SharedLibraryCore.Services;
using IW4MAdmin.Plugins.Stats.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IW4MAdmin.Plugins.Stats.Helpers
{
    public class ThreadSafeStatsService
    {
        public GenericRepository<EFClientStatistics> ClientStatSvc
        {
            get
            {
                return new GenericRepository<EFClientStatistics>(true);
            }
        }
        public GenericRepository<EFServer> ServerSvc { get; private set; }
        public GenericRepository<EFClientKill> KillStatsSvc { get; private set; }
        public GenericRepository<EFServerStatistics> ServerStatsSvc { get; private set; }
        public GenericRepository<EFClientMessage> MessageSvc
        {
            get
            {
                return new GenericRepository<EFClientMessage>();
            }
        }

        public ThreadSafeStatsService()
        {
            ServerSvc = new GenericRepository<EFServer>();
            KillStatsSvc = new GenericRepository<EFClientKill>();
            ServerStatsSvc = new GenericRepository<EFServerStatistics>();
        }
    }
}
