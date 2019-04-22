using Assignment_ACE.DataClass;

namespace Assignment_ACE.Visitor
{
    public class SummaryVisitor
    {
        public int bookCount = 0;
        public int bookStock = 0;
        public int eBookCount = 0;
        public int eBookStock = 0;
        public int videoPCount = 0;
        public int videoPStock = 0;
        public int videoDCount = 0;
        public int audioPCount = 0;
        public int audioDCount = 0;
        public int audioPStock = 0;

        public void visit(MaterialInfo item)
        {
            item.accept(this);
        }
    }
}