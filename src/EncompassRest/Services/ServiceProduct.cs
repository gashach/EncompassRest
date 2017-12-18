namespace EncompassRest.Services
{
    public abstract class ServiceProduct<TServiceOptions> : ExtensibleObject
        where TServiceOptions : ServiceOptions
    {
        public EntityReference EntityRef { get; set; }
        public  string Name { get; set; }
        public abstract TServiceOptions Options { get; }
        public ServicePreferences Preferences { get; set; }
        public ServiceCredentials Credentials { get; set; }
        //public string BranchId { get; set; }
    }
}
