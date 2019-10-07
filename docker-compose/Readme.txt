docker swarm init

docker stack deploy -c docker-compose.yml replicas_php

docker service ls

docker stack services replicas_php

docker service ps <name_service> (replicas_php_web) o docker stack ps replicas_php

http://localhost:4000
curl -4 http://localhost:4000

docker stack rm replicas_php

bajar el docker swarm
docker swarm leave --force