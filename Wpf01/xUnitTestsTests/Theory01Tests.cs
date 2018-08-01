using Xunit;
using xUnitTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTests.Tests
{
    public class Theory01Tests
    {
        private Theory01 target = new Theory01();

        [Theory(DisplayName = "とりあえず")]
        [MemberData(nameof(GetSource))]
        public void KakuninTest(IEnumerable<int> lllll, IEnumerable<int> yyyyy)
        {
            target.Kakunin();
        }

        public static IEnumerable<object[]> GetSource()
        {
            yield return new object[] { new List<int>(){ 1, 2 }, new List<int>() { 3, 4 } };
            yield return new object[] { new List<int>() { 5, 6 }, new List<int>() { 7, 8 } };
            ////yield return new object[] { 1, 0 };
            ////yield return new object[] { 1, 1 };
            ////yield return new object[] { 2, 1 };
        }

        ////public static IEnumerable<object[][]> GetSource()
        ////{
        ////    object[][] a = new object[][]
        ////    {  // 3行2列の行列
        ////        new object[]{1, 2},
        ////        new object[]{2, 1},
        ////        new object[]{0, 1}
        ////    };

        ////    List<object[][]> aaa = new List<object[][]>();
        ////    aaa.Add(a);

        ////    return aaa;

        ////    ////var list = new List<object[][]>()
        ////    ////{
        ////    ////    new object[][] { new object[] { 0, 0, 0 }, new object[] { 1, 1, 1 } },
        ////    ////    ////new object[] { 1, 0, 1 },
        ////    ////};

        ////    ////return list;
        ////    ////int[] sss = new int[]();

        ////    ////list.Add(new int[ 1, 1, 1 ] );

        ////    ////yield return new object[] { 0, 0, 0 };
        ////    ////yield return new object[] { 1, 0, 1 };
        ////    ////yield return new object[] { 1, 1, 0 };
        ////    ////yield return new object[] { 2, 1, 1 };
        ////}

        // テストデータ２: メソッド
        public static IEnumerable<object[]> MakeAddTestData(int from, int count)
        {
            return Enumerable.Range(from, count).Select(i => new object[] { i, i, i + i });
        }
    }
}