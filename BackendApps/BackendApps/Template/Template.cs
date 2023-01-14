using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace BackendApps.Template
{

    public abstract class ScoringAlgoritm
    {
        public int GemerateScore(int hits, TimeSpan time)
        {
            int scıre = CalculateBaseScore(hits);
            int reduction = CalsulateReduction(time);
            return calculateOverAllReduction(scıre, reduction);
        }

        public abstract int CalsulateReduction(TimeSpan time);
        public abstract int calculateOverAllReduction(int score, int reduction);

        public abstract int CalculateBaseScore(int hits);
    }
    public class MensScoringAlgoritm : ScoringAlgoritm
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 100;
        }

        public override int calculateOverAllReduction(int score, int reduction)
        {
            return score - reduction;
        }

        public override int CalsulateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 5;
        }
    }
    public class WomensScoringAlgoritm : ScoringAlgoritm
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 200;
        }

        public override int calculateOverAllReduction(int score, int reduction)
        {
            return score - reduction;
        }

        public override int CalsulateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 20; ;

        }
    }
    public class ChildrensScoringAlgoritm : ScoringAlgoritm
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 300;
        }

        public override int calculateOverAllReduction(int score, int reduction)
        {
            return score - reduction;
        }

        public override int CalsulateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 20; ;

        }
    }
}
