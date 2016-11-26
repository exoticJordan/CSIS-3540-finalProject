SELECT DISTINCT
    B.Room_Number AS RNUM
FROM
    Rooms AS R
        INNER JOIN
    Booking AS B ON R.Room_Number = B.Room_Number
        INNER JOIN
    Travellers AS T ON B.Traveller_ID = T.TVL_ID
WHERE
    B.Room_Number = 514
        AND T.TVL_FName = 'John'