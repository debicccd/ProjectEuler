/*
 * Created by SharpDevelop.
 * User: Spidey7003
 * Date: 6/28/2016
 * Time: 5:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProjectEuler
{
	/// <summary>
	/// Description of P100.
	/// </summary>
	public class P100
	{
		
		public static void solve(long min){

			
			for(long i = 1; i <= long.MaxValue; i++){
				long n = (long) Math.Sqrt( (8*i*i) - (8*i) + 1 );
			
				if( (n+1)/2 < min ){
					continue;
				}
							
				if(isSquare( (8*i*i) - (8*i) + 1) ){
					
					if(n % 2 == 1){
						Console.WriteLine( i );
						break;
					}
				}
			}
		}
		
		public static bool isSquare(long n){
			long i = 1;
			for (; ; )
			{
				if (n < 0)
					return false;
				if (n == 0)
					return true;
				n -= i;
				i += 2;
			}
		}
	}
}
