ssh.net
=======

git export of https://sshnet.codeplex.com/


## initial checkout
```bash
$ cat authors.txt
SND\drieseng_cp = drieseng <drieseng@codeplex.com>
SND\olegkap_cp = olegkap <olegkap@codeplex.com>
SND\Kenneth_aa_cp = Kenneth_aa <Kenneth_aa@codeplex.com>
SND\GiantJunkBox_cp = GiantJunkBox <GiantJunkBox@codeplex.com>
vstfs:///Framework/IdentityDomain/91bfc952-fec6-4be4-b192-9eb3b8389945\Project Collection Service Accounts = Project Collection Service Accounts <blabla@codeplex.com>
SND\diehardvn_cp = diehardvn <diehardvn@codeplex.com>
$ git svn clone --no-metadata https://sshnet.svn.codeplex.com/svn/ ssh.net --revision 9489:35331 --authors-file=authors.txt
```

We need to skip some commits from the early days else the export would fail.

## update

```bash
$ git svn fetch
$ git rebase origin/master git-svn
$ git checkout -b update
$ git rebase update master
$ git checkout master
$ git branch -D update
$ git push
```
