using solid_group_puzzle.good.LogicLayerServices;
using solid_group_puzzle.good.PresentationLayerServices;

namespace solid_group_puzzle.good.LogicLayer
{
    public class LogicB : IPresentationService
    {
        private readonly ILogicService _dataAccess;

        public LogicB(ILogicService dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public string GetLogicDataEnhanced()
        {
            return $"ServiceB: {_dataAccess.GetData}";
        }
    }
}
