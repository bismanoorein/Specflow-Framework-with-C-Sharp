//using SeFramework.Pages;

//namespace SeFramework.PageAssembly
//{
//    public class Page: Drivers
//    {
//        Drivers driver { get; }
       
//        public Page(Drivers _driver )
//        {
//            driver = _driver;
           
//        }
//        public T GetPages<T>()
//        {
//            var page = (T?)Activator.CreateInstance(typeof(T?), driver.SetDriver);
//            return page;
//        }

//        public Signin Login => GetPages<Signin>();    
       
//        public CreateAccount CreateAccount => GetPages<CreateAccount>();
//    }
//}