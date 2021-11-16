// I tried this solution but we have a precision issue.
public class Tortoise
{
  public static int[] Race(int v1, int v2, int g) 
  {
    if(v1 >= v2)
    {
      return null;
    }
    
    double timeToCatch = (double)g/(double)(v2 - v1);
 
    int hour = (int)timeToCatch;
    double  min = (timeToCatch -(int)timeToCatch)*60.0;
    double sec =  (min -(int)min)*60.0;

    return new int[]{hour,(int)min, (int)sec};
  }
}

//The Best solution : 
// public class Tortoise
// {
//   public static int[] Race(int v1, int v2, int g) // speed racer 1 , speed racer 2 , distance between them
//   {
//     if(v1 >= v2) // if v1 is faster than v2
//       return null;
//     var ts = System.TimeSpan.FromSeconds((g * 3600) / (v2 - v1));
//     return new[] { ts.Hours, ts.Minutes, ts.Seconds };
//   }
// }