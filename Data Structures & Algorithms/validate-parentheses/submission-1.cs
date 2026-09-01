public class Solution {
    public bool IsValid(string s) {
        List<char> sChar = new List<char>();
        Dictionary<char,char> closeToOpen = new Dictionary<char,char>() { { ')' , '(' }, { '}' , '{' }, { ']' , '[' } };

        foreach(var c in s){
            if(closeToOpen.ContainsKey(c)){
                if(sChar.Count > 0 && sChar[sChar.Count - 1] == closeToOpen[c]){
                    sChar.RemoveAt(sChar.Count - 1);
                } else {
                    return false;
                }
            } else {
                sChar.Add(c);
            }
        }

        if(!sChar.Any()){
            return true;
        } else {
            return false;
        }
    }
}
