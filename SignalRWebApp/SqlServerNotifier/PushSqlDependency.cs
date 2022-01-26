using System;
using System.Data.SqlClient;

namespace SignalRWebApp.SqlServerNotifier
{
    public class PushSqlDependency
    {
        static PushSqlDependency instance = null;
        readonly SqlDependencyRegister sqlDependencyNotifier;
        readonly Action<String> dispatcher;

        public static PushSqlDependency Instance(NotifierEntity notifierEntity, Action<String> dispatcher)
        {
            if (instance == null)
                instance = new PushSqlDependency(notifierEntity, dispatcher);
            return instance;
        }

        private PushSqlDependency(NotifierEntity notifierEntity, Action<String> dispatcher)
        {
            this.dispatcher = dispatcher;
            sqlDependencyNotifier = new SqlDependencyRegister(notifierEntity);
            sqlDependencyNotifier.SqlNotification += OnSqlDependencyNotifierResultChanged;
        }
 
        internal void OnSqlDependencyNotifierResultChanged(object sender, SqlNotificationEventArgs e)
        {
            dispatcher("Refresh");
        }
    }
}