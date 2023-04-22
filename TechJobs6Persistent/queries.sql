-- Capture your answer here for each "Test It With SQL" section of this assignment
    -- write each as comments


--Part 1: List the columns and their data types in the Jobs table.

--int Id
--longtext Name
--int EmployerId

--Part 2: Write a query to list the names of the employers in St. Louis City.

SELECT Name
FROM employers
WHERE Location = "St. Louis City";



--Part 3: Write a query to return a list of the names of all skills that are attached to jobs in alphabetical order.
    --If a skill does not have a job listed, it should not be included in the results of this query.

    SELECT * 
    FROM Skills
    LEFT JOIN JobSkills ON Skill.Id = JobSkills.SkillId
    WHERE JobSkills.JobId IS NOT NULL 
    ORDER BY name ASC;