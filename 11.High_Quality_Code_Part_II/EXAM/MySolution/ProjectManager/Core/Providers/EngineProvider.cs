using ProjectManager.Core.Contracts;

namespace ProjectManager
{
    internal class EngineProvider
    {
        private IEngine engine;

        public EngineProvider(IEngine engine)
        {
            this.engine = engine;
        }

        public void Start()
        {
            this.engine.Start();
        }
    }
}