using SpaUserControl.Domain.Contracts.Services;
using SpaUserControl.Startup;
using System;
using System.Globalization;
using System.Threading;
using Unity;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;

            var container = new UnityContainer();
            DependencyResolver.Resolve(container);

            var service = container.Resolve<IUserService>();
            try
            {
                service.Register("Dho", "dho619@hotmail.com", "dho619", "dho619");
                Console.WriteLine("Usuário cadastrado com sucesso!");
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                service.Dispose();
            }
        }
    }
}