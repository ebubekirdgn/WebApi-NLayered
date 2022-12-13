namespace NLayer.Core.UnifOfWorks
{
    public interface IUnifOfWorks
    {
        Task CommitAsync();
        void Commit();
    }
}