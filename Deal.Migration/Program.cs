using Deal.Data.Crud;
using Deal.Service.SeedServices;
using DoItWright.Library.DependencyInjection;
using DoItWright.Library.Logging;

namespace Deal.Migration
{
    public static class Program
    {
        /// <summary>
        /// Main
        /// </summary>
        public static void Main(/*string[] args*/)
        {
            ICaller caller = new Caller("Seeder");
            DependencyInjection();
            ISeedService seedService = InstanceFactory.GetInstance<ISeedService>();
            seedService.Suits(caller);
            seedService.Ranks(caller);
            seedService.Cards(caller);
            seedService.PackColours(caller);
            seedService.SetColours(caller);
            seedService.ErrorReasonGroups(caller);
            seedService.ErrorReasons(caller);
            seedService.SetPurposes(caller);
            seedService.Owners(caller);
            seedService.Sets(caller);
            seedService.Dealers(caller);
            seedService.Organisers(caller);
        }

        private static void DependencyInjection()
        {
            InstanceFactory.RegisterTransient<ISeedService, SeedService>();
            InstanceFactory.RegisterTransient<IDealData, DealData>();
        }
    }
}