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
            seedService.ErrorReasons();
            seedService.SetPurposes();
            seedService.Owners();
            seedService.Sets();
            seedService.Dealers();
            seedService.Organisers();
        }

        private static void DependencyInjection()
        {
            InstanceFactory.RegisterTransient<ISeedService, SeedService>();
            InstanceFactory.RegisterTransient<IDealData, DealData>();
        }
    }
}