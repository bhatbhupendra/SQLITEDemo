using SQLITEDemo.MVVM.Models;
using SQLITEDemo.MVVM.Views;
using SQLITEDemo.Repositorities;

namespace SQLITEDemo
{
	public partial class App : Application
	{
		//public static CustomerRepository CustomerRepo { get; private set; }
		public static BaseRepository<Customer> CustomerRepo { get; private set; }
		public static BaseRepository<Order> OrdersRepo { get; private set; }
		public static BaseRepository<Passport> PassportRepo { get; private set; }
		public App(BaseRepository<Customer> repo, 
					BaseRepository<Order> orderRepo,
					BaseRepository<Passport> passwordRepo)
		{
			InitializeComponent();
			CustomerRepo = repo;
			OrdersRepo = orderRepo;
			PassportRepo = passwordRepo;

			MainPage = new MainPage();
		}
	}
}
