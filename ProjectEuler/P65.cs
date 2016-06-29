/*
 * Created by SharpDevelop.
 * User: Spidey7003
 * Date: 6/28/2016
 * Time: 8:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProjectEuler
{
	/// <summary>
	/// Description of P65.
	/// </summary>
	public class P65
	{
		Fraction one = new Fraction(1,1);
		
		public static void solve(int n){
			int[] sequence = new int[n];
			
			for(int i = 0; i < n; i++){
				if(i % 3 == 0 || i % 3 == 2){
					sequence[i] = 1;
				} else{
					sequence[i] = (i + 2) / 3 * 2;
				}
			}
			
			for(int i = 0; i < n; i++){
				if(i % 3 == 0 || i % 3 == 2){
					sequence[i] = 1;
				} else{
					sequence[i] = (i + 2) / 3 * 2;
				}
			}
			
			Fraction result = new Fraction(1,sequence[n-1]);
			
			for(int i = n-2; i >= 0; i--){
				//Console.WriteLine(result);
				result.add(new Fraction(sequence[i],1));
				result.invert();
			}
			
			result.add(new Fraction(2,1));
			
			Console.WriteLine(result);
		}
	}
}
