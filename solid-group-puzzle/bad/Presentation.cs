namespace solid_group_puzzle.bad
{
    public class Presentation
    {
        private LogicA _logicA;
        private LogicB _logicB;

        public Presentation(LogicA logicA, LogicB logicB)
        {
            _logicA = logicA;
            _logicB = logicB;
        }

        public void PresentA()
        {
            Console.WriteLine(_logicA.GetLogicDataEnhanced());
        }

        public void PresentB()
        {
            Console.WriteLine(_logicB.GetLogicDataEnhanced());
        }
    }
}
