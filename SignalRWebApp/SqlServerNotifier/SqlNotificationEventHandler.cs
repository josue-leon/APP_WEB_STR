using System.Data.SqlClient;

namespace SignalRWebApp.SqlServerNotifier
{
    public delegate void SqlNotificationEventHandler(object sender, SqlNotificationEventArgs e);
}