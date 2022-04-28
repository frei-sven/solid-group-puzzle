namespace solid_group_puzzle.bad
{
    public class LogicA
    {
        private readonly DataAccess _dataAccess;

        public LogicA(DataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public string GetLogicDataEnhanced()
        {
            return $"ServiceA: {_dataAccess.GetData}";
        }
    }
}
