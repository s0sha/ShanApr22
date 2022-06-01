cd c:/ShanApr22/ShanApr22/APITests22
newman run "Apr2022 Employee CRUD E2E Test.postman_collection.json" -e "Apr22.postman_environment.json"
newman run "Apr2022 Employee CRUD E2E Test.postman_collection.json" -e "Apr22.postman_environment.json" -r htmlextra