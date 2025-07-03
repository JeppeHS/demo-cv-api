# Demo CV API application
For demonstration purposes

## Dokku create app
* SSH to server (locally)
	* ``ssh root@68.183.241.236``
* Create dokku app (server)
	* ``dokku apps:create democvapi``
* Add domain (server)
	* ``dokku domains:set democvapi democvapi.celepus.com``
* Setup https (server)
	* ``dokku letsencrypt:enable democvapi``
* Add git remote (locally)
	* ``git remote add dokku dokku@68.183.241.236:democvapi``

## Dokku deployment
* Push to dokku (locally)
	* ``git push dokku main:master``