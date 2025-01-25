using ShowList;
namespace TestProject1  
{
    public class UnitTest1
    {
        [Fact]
        public void Create()
        {
            MyList z = new MyList();
            Assert.NotNull(z);

        }
        [Fact]
        public void goS()
        {
            MyList z = new MyList();
            z.Append("q");
            z.Append("qq");
            z.Append("qqq");
            z.ToEnd();
            z.ToStart();
            Assert.True(z.GetCur()=="q");

        }
        [Fact]
        public void goE()
        {
            MyList z = new MyList();
            z.Append("q");
            z.Append("qq");
            z.Append("qqq");
            z.ToStart();
            z.ToEnd();
            Assert.True(z.GetCur() == "qqq");

        }
        [Fact]
        public void chekQ()
        {
            MyList z = new MyList();
            z.Append("q");
            z.Append("qq");
            z.Append("qqq");
            Assert.True(z.Q() == 3);

        }
        [Fact]
        public void testApp()
        {
            MyList z = new MyList();
            z.Append("q");
            z.Append("qq");
            z.Append("qqq");
            z.ToStart();
            Assert.True(z.GetCur() == "q");

        }
        [Fact]
        public void testToNext()
        {
            MyList z = new MyList();
            z.Append("q"); 
            z.Append("qq");
            z.ToNext();
            z.Append("qqq");
          
            Assert.True(z.GetCur() == "qq");

        }
        [Fact]
        public void testToPrev()
        {
            MyList z = new MyList();
            z.Append("q");
            z.Append("qq");
            z.Append("qqq");
            z.ToEnd();
            z.ToPrev();

            Assert.True(z.GetCur() == "qq");

        }
        [Fact]
        public void testNext()
        {
            MyList z = new MyList();
            z.Append("q");
            z.Append("qq");
            z.next("w");

            Assert.True(z.GetCur() == "w");

        }
        [Fact]
        public void testPrev()
        {
            MyList z = new MyList();
            z.Append("q");
            z.Append("qq");
            z.ToNext();
            z.prev("w");
            z.ToPrev();    

            Assert.True(z.GetCur() == "w");

        }
        [Fact]
        public void delete()
        {
            MyList z = new MyList();
            z.Append("q");
            z.Append("qq");
            z.delete();
            z.ToStart();

            Assert.True(z.GetCur() == "qq");

        }
        [Fact]
        public void testUp()
        {
            MyList z = new MyList();
            z.upend("q");
            z.upend("qq");
            z.upend("qqq");
            z.ToStart();
            Assert.True(z.GetCur() == "qqq");

        }
        [Fact]
        public void getcur()
        {
            MyList z = new MyList();
            Assert.Throws<Exception>(() => {z.GetCur();}) ;

        }

        [Fact]
        public void Test4()
        {
            MyList z = new MyList();
            Assert.NotNull(z);

        }
    }
}