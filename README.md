# Example default configuration

```json
{
  "inputs": [],
  "servers": {
    "MCP_demo_server": {
      "type": "sse",
      "url": "http://localhost:8000/sse"
    }
  }
}
```

# Jira and Confluence postgress setup

```
docker exec -it postgresql psql -h localhost -U root

CREATE USER jira WITH PASSWORD 'password';
CREATE DATABASE jira;
GRANT ALL PRIVILEGES ON DATABASE "jira" to jira;

CREATE USER confluence WITH PASSWORD 'password';
CREATE DATABASE confluence;
GRANT ALL ON SCHEMA public TO confluence; 
ALTER DATABASE confluence OWNER TO confluence;

GRANT ALL PRIVILEGES ON DATABASE "confluence" to confluence;
```
