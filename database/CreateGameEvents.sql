/*
    GameAnalytics Platform
    Script: CreateGameEvents.sql

    Purpose:
    Creates the table used to store gameplay events received from Unity.
    
    Author:
    Benedict
*/

-- Select the database we want to use
USE GameAnalytics;

-- Create the table that stores player gameplay events
CREATE TABLE GameEvents
(
    -- Automatically generated unique ID
    Id INT IDENTITY(1,1) PRIMARY KEY,
    -- The name of the event (enemy killed, level completed, etc.)
    EventName NVARCHAR(100) NOT NULL,
    -- Extra information about the event
    EventData NVARCHAR(MAX),
    -- When the event occurred
    Timestamp DATETIME2 NOT NULL
);