cd "C:\Users\a.francavilla.3537\Desktop\Francavillaandrea"
git add .

echo "Inserisci il messaggio del commit: "
read commit_message

git commit -m "$commit_message"

git push origin master