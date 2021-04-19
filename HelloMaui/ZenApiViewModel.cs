namespace HelloMaui
{
    public class ZenApiViewModel : ViewModelBase
    {
        private ConnectionStatus _connectionStatus = HelloMaui.ConnectionStatus.Disconnected;
        public string ConnectionStatus => _connectionStatus == HelloMaui.ConnectionStatus.Connected ? "Connected" : "Disconnected";

        public void Connect()
        {
            _connectionStatus = HelloMaui.ConnectionStatus.Connected;
            OnPropertyChanged("ConnectionStatus");
        }

        public void Disconnect()
        {
            _connectionStatus = HelloMaui.ConnectionStatus.Disconnected;
            OnPropertyChanged("ConnectionStatus");
        }
    }

    enum ConnectionStatus
    {
        Unknown,
        Disconnected,
        Connected,
    }
}