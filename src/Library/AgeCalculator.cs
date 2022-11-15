using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Library;

public class AgeCalculator<Person>: Visitor<Person>
{
   
   public override void Visit(Node<Person> person)
   {
   int sum= 0;

   }
   
}