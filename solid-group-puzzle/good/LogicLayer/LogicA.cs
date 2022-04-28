using solid_group_puzzle.good.LogicLayerServices;
using solid_group_puzzle.good.PresentationLayerServices;

namespace solid_group_puzzle.good.LogicLayer
{
    public class LogicA : IPresentationService
    {
        private readonly ILogicService _dataAccess;

        public LogicA(ILogicService dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public string GetLogicDataEnhanced()
        {
            return $"ServiceA: {_dataAccess.GetData}";
        }
    }
}
