namespace QFramework.GraphDesigner
{
    public interface IContextMenuQuery
    {
        void QueryContextMenu(ContextMenuUI ui, MouseEvent evt, params object[] obj);
    }
}