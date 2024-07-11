using System.Collections;

namespace ConsoleApp1;

public class collections
{

    // collections is a built is a set of various built in data types an their various functions like ArrayList, Dictionary, Queue 


    // KeyValuePair<int, string> kv = new KeyValuePair<int, string> (4, "King");
    KeyValuePair<int, string> kv = new (4, "King");

    // Dictionary<int,string> d = new Dictionary<int, string> () { 
    //     {1,"King"},
    //    { 2,"Queen"}
    // };
    Dictionary<int,string> d = new () { 
        {1,"King"},
       { 2,"Queen"}
    };


    ArrayList al = new () {1,653,};
    // ArrayList al = new  ArrayList() {1,653,};

    
}
