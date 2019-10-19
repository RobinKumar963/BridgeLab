// --------------------------------------------------------------------------------------------------------------------
// <copyright file=SimpleBalancedParanthesis.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// --------------------------------------------------------------------------------------------------------------------


using System;
namespace Bridgelabz.DataStructure
{
    /// <summary>
    /// Illustration of Stack with Checking Balanced Paranthesis
    /// </summary>
    public class SimpleBalancedParanthesis
    {


        public static void main(String[] args)
        {
            Console.WriteLine("Enter expression:");
            String arthimeticExpression = Console.ReadLine();
            Utility.Stack<char> stack= new Utility.Stack<char>();
            for(int i=0;i < arthimeticExpression.Length;i++)
            {
                ////On encountring ( push it
                if(arthimeticExpression[i] == '(')
                    stack.push(arthimeticExpression[i]);
                ////on encountring pop it
                if (arthimeticExpression[i] == ')')
                    stack.pop();

            }
            ////If stack has 0 ( it means expression has equal number of )
            if (stack.IsEmpty())
                Console.WriteLine("Balanced paranthesis");
            else
                Console.WriteLine("Not Balanced");
        }

    }
}
