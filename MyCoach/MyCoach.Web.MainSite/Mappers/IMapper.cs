namespace MyCoach.Web.MainSite.Mappers
{
    public interface IMapper<in TSource, out TResult>
    {
        TResult Map(TSource source);
    }

    public interface IMapper<in TSource1, in TSource2, out TResult>
    {
        TResult Map(TSource1 source1, TSource2 source2);
    }
}