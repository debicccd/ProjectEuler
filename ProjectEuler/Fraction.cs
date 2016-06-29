/*
 * Created by SharpDevelop.
 * User: Spidey7003
 * Date: 6/28/2016
 * Time: 9:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProjectEuler
{
	/// <summary>
	/// Description of Fraction.
	/// </summary>
	public class Fraction
	{
		int num;
		int denom;
		
		public Fraction(int n, int d){
			num = n;
			denom = d;
		}
		
		public void reduce(){
			int i = 2;
			
			while(i <= num && i <= denom){
				if(num % i == 0 && denom % i == 0){
					num /= i;
					denom /= i;
				} else{
					i++;
				}
			}
		}
		
		public void add(Fraction other){
			num = num * other.denom + other.num * denom;
			denom = denom * other.denom;
			
			this.reduce();
		}
		
		public void sub(Fraction other){
			other.num *= -1;
			this.add(other);
		}
		
		public void mult(Fraction other){
			num *= other.num;
			denom *= other.denom;
			
			this.reduce();
		}
		
		public void div(Fraction other){
			other.invert();
			this.mult(other);
		}
		
		public void invert(){
			int temp = num;
			num = denom;
			denom = temp;
		}
		
		public override string ToString(){
			return num + "\\" + denom;
		}
	}
}
