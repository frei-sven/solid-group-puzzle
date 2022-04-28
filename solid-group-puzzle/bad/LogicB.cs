namespace solid_group_puzzle.bad
{
    public class LogicB
    {
        private readonly DataAccess _dataAccess;

        public LogicB(DataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public string GetLogicDataEnhanced()
        {
            return $"ServiceB: {_dataAccess.GetData}";
        }
    }
}
