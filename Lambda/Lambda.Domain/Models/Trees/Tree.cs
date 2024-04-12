namespace Lambda.Domain.Models.Trees
{
    public class Tree
    {

        public List<TreePath> Paths { get; set; }

        public Tree()
        {
            this.Paths = new List<TreePath>();
        }

        public Tree(List<TreePath> paths)
        {
            Paths = paths;
        }
    }

}
