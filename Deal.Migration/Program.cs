using Deal.Data.Crud;
using Deal.Service.SeedServices;
using DoItWright.Library.DependencyInjection;

namespace Deal.Migration
{
    public static class Program
    {
        /// <summary>
        /// Main
        /// </summary>
        public static void Main(/*string[] args*/)
        {
            DependencyInjection();
            ISeedService seedService = InstanceFactory.GetInstance<ISeedService>();
            seedService.Suits();
            seedService.Ranks();
            seedService.Cards();
            seedService.PackColours();
            seedService.SetColours();
            seedService.ErrorReasonGroups();
        }

        private static void DependencyInjection()
        {
            InstanceFactory.RegisterTransient<ISeedService, SeedService>();
            InstanceFactory.RegisterTransient<IDealData, DealData>();
        }
    }
}