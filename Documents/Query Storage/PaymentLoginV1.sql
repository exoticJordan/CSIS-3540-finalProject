SELECT DISTINCT
    B.Room_Number AS RNUM, T.TVL_FName AS FNAME
FROM
    Rooms AS R
        INNER JOIN
    Booking AS B ON R.Room_Number = B.Room_Number
        INNER JOIN
    Travellers AS T ON B.Traveller_ID = T.TVL_ID
WHERE
    B.Room_Number = 514;
        
        
SELECT DISTINCT
    P.Room_Num AS Room,
    P.Purchase_Date AS `Date`,
    P.Purchase_Time AS `TIME`,
    P.TotalCost AS `COST(USD)`,
    F.Facility_Name AS Location,
    S.Ship_Name AS Ship,
    C.Cruise_Name AS Cruise
FROM
    Purchases AS P
        INNER JOIN
    Rooms AS R ON R.Room_Number = P.Room_Num
        INNER JOIN
    Facility AS F ON F.Facility_ID = P.Facility_ID
        INNER JOIN
    Cruises AS C ON C.Cruise_id = P.Cruise_ID
        INNER JOIN
    Ships AS S ON S.Ship_id = P.Ship_ID
WHERE
    P.Room_Num = 514 AND P.Ship_ID = 1
        AND P.Cruise_ID = 2