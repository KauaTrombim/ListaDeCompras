using ListaDeCompras.Helpers;

namespace ListaDeCompras
{
    public partial class App : Application
    {
        static SQliteDatabaseHelper _db;

        public static SQliteDatabaseHelper DB
        {
            get
            {
                if (_db == null)
                {
                    string path = Path.Combine(
                            Environment.GetFolderPath(
                                Environment.SpecialFolder.LocalApplicationData),
                                "banco_sqlite_compras.db3"
                        );

                    _db = new SQliteDatabaseHelper(path);
                }
                return _db;
            }
        }
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new Views.ListaProduto()));
        }
    }
}