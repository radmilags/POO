#include <iostream>
using namespace std;
int main() 
{
  string s; char c; bool t;
  getline(cin, s);
  while (s[0] != '*') 
  {
    c = tolower(s[0]); t = true ;

    for (unsigned int i = 1; i < s.length() - 1; i++)
    if (s[i] == ' ' && tolower(s[i+1]) != c) 
    {
      t = false;
      break;
    }
    if (t) cout << "Y\n";
    else cout << "N\n";
    getline(cin, s);
  }
  return 0;
}
