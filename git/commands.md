Command | Description
--- | ---
pull | Pull down latest changes
status | Shows what branch you're on and the status of files
gui | Open a graphical interface for git actions
checkout -b *BranchName* | Checkout and create a branch
commit -m "*Message*" | Commit the staged files with a message
push -u origin *BranchName* | Push the local branch remotely
reset HEAD~ | Undo the last local commit
merge master | When in a branch off of master, take the commits from master and merge them into your branch
