 private static string vittoria(string[,] m, string giocatore)
 {
     if ((t[0, 0] == ch && t[0, 1] == ch && t[0, 2] == ch) ||
             (t[1, 0] == ch && t[1, 1] == ch && t[1, 2] == ch) ||
             (t[2, 0] == ch && t[2, 1] == ch && t[2, 2] == ch) ||
             (t[0, 0] == ch && t[1, 0] == ch && t[2, 0] == ch) ||
             (t[0, 1] == ch && t[1, 1] == ch && t[2, 1] == ch) ||
             (t[0, 2] == ch && t[1, 2] == ch && t[2, 2] == ch) ||
             (t[0, 0] == ch && t[1, 1] == ch && t[2, 2] == ch) ||
             (t[0, 2] == ch && t[1, 1] == ch && t[2, 0] == ch))
         return ch;
     else
         return " ";
 }