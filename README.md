# Read_Bulks_TPS_RestAPI

instractions:

1. clone the project and make a build.

2. For get a bulk data,
   send JSON object in the Request body method in the Swagger like that:
   
{
  "startFrom": "1900-01-10T00:00:00+00:02",
  "bulkAmount": 5
}
