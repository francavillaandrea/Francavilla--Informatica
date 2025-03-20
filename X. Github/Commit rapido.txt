echo "Inserisci 1 se vuoi pullare la repository, 2 se vuoi committare delle modifiche, 3 se vuoi clonare una repository"
read input

# Cambia il percorso della tua repository
cd "./Desktop/Francavillaandrea" || exit

if [ "$input" -eq 1 ]; then
    # Pull della repository
    git pull
elif [ "$input" -eq 2 ]; then
    # Aggiungi i cambiamenti
    git add .

    # Chiedi il messaggio del commit
    echo "Inserisci il messaggio del commit: "
    read commit_message

    # Commit e push
    git commit -m "$commit_message"
    git push origin master
elif [ "$input" -eq 3 ]; then
    # Clona la repository
    echo "Inserisci l'URL della repository da clonare: "
    read repo_url
    git clone "$repo_url"
else
    echo "Opzione non valida"
fi
