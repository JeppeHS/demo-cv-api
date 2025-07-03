# Demo CV API application
For demonstration purposes

## Dokku create app
* SSH to server (locally)
	* ``ssh root@129.212.142.3``
* Create dokku app (server)
	* ``dokku apps:create democvapi``
* Add domain (server)
	* ``dokku domains:set democvapi democvapi.do-more.site``
* Setup https (server)
	* ``dokku letsencrypt:enable democvapi``
* Add git remote (locally)
	* ``git remote add dokku dokku@129.212.142.3:democvapi``

## Dokku deployment
* Push to dokku (locally)
	* ``git push dokku main:master``