using Autofac;
using FundooRepos;
using FundooRepos.Interface;
using NUnit.Framework;
using static System.Collections.Immutable.ImmutableArray;


namespace FundooAPITest
{
    public class AddNotesTest
    {
        
       

        [SetUp]
        public void Setup()
        {
            var builder = new ContainerBuilder();

            //Register types that expose interfaces...
            //Autofac.Builder.RegisterType<>(INoteRepository)
            //    .As<>(NoteRepository);
        }

        [Test]
        public void Test1() 
        {
            //Assert.Pass();
        }
    }
}