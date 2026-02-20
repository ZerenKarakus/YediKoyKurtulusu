namespace YediKoyunKurtulusu
{
    public class BSTNode
    {
        public string Veri;
        public BSTNode Sol;
        public BSTNode Sag;

        public BSTNode(string veri)
        {
            Veri = veri;
            Sol = null;
            Sag = null;
        }
    }
}
