DROP SCHEMA public CASCADE;
CREATE SCHEMA public;

-- СОЗДАЮ ВСЕ ТАБЛИЦЫ БД

CREATE TABLE IF NOT EXISTS Users (
	UserId SERIAL PRIMARY KEY,
	FirstName TEXT,
	SecondName TEXT,
	MiddleName TEXT,
	PhoneNumber TEXT,
	Email TEXT,
	Telegram TEXT,
	VK TEXT
);

CREATE TABLE IF NOT EXISTS Files (
	FileId SERIAL PRIMARY KEY,
	FileName TEXT,
	FileType TEXT,
	Content BYTEA
);

CREATE TABLE IF NOT EXISTS Images (
	ImageId SERIAL PRIMARY KEY,
	FileName TEXT,
	FileType TEXT,
	Content BYTEA
);

CREATE TABLE IF NOT EXISTS Staff (
	StaffId SERIAL PRIMARY KEY,
	UserId SERIAL,
	DateEmpl TIMESTAMP,
	FOREIGN KEY (UserId) REFERENCES Users(UserId)
);

CREATE TABLE IF NOT EXISTS StaffDocuments (
	DocumentId SERIAL PRIMARY KEY,
	StaffId SERIAL,
	FOREIGN KEY (StaffId) REFERENCES Staff(StaffId)
);

CREATE TABLE IF NOT EXISTS StaffDocumentScans (
	ScanId SERIAL PRIMARY KEY,
	DocumentId SERIAL,
	ImageId SERIAL,
	FOREIGN KEY (DocumentId) REFERENCES StaffDocuments(DocumentId),
	FOREIGN KEY (ImageId) REFERENCES Images(ImageId)
);

CREATE TABLE IF NOT EXISTS Owners (
	OwnerId SERIAL PRIMARY KEY,
	UserId SERIAL,
	OrganizationId INT,
	FOREIGN KEY (UserId) REFERENCES Users(UserId)
);

CREATE TABLE IF NOT EXISTS Organizations (
	OrganizationId SERIAL PRIMARY KEY,
	Name TEXT,
	Type TEXT,
	OwnerId SERIAL,
	FOREIGN KEY (OwnerId) REFERENCES Owners(OwnerId)
);

ALTER TABLE Owners
ADD FOREIGN KEY (OrganizationId) REFERENCES Organizations(OrganizationId);

CREATE TABLE IF NOT EXISTS Contracts (
	ContractId SERIAL PRIMARY KEY,
	OrganizationId INT,
	OwnerId INT,
	IsLegalEntity BOOL NOT NULL,
	SignDate TIMESTAMP,
	Address TEXT,
	Comment TEXT,
	FOREIGN KEY (OrganizationId) REFERENCES Organizations(OrganizationId),
	FOREIGN KEY (OwnerId) REFERENCES Owners(OwnerId)
);

CREATE TABLE IF NOT EXISTS Crews (
    CrewId SERIAL PRIMARY KEY,
    Name TEXT NOT NULL,
    LeaderId SERIAL
);

CREATE TABLE IF NOT EXISTS CrewMembers (
    MemberId SERIAL PRIMARY KEY,
    Name TEXT NOT NULL,
    CrewId INT,
	UserId SERIAL,
	FOREIGN KEY (UserId) REFERENCES Users(UserId)
);

ALTER TABLE Crews
ADD FOREIGN KEY (LeaderId) REFERENCES CrewMembers(MemberId);

ALTER TABLE CrewMembers
ADD FOREIGN KEY (CrewId) REFERENCES Crews(CrewId);

CREATE TABLE IF NOT EXISTS CrewCalls (
	CallId SERIAL PRIMARY KEY,
	CallType INT,
	DateTime TIMESTAMP,
	CrewId SERIAL,
	ContractId SERIAL,
	FOREIGN KEY (CrewId) REFERENCES Crews(CrewId),
	FOREIGN KEY (ContractId) REFERENCES Contracts(ContractId)
);

CREATE TABLE IF NOT EXISTS Alarms (
	AlarmId SERIAL PRIMARY KEY,
	ResultType INT,
	DateTime TIMESTAMP,
	Comment TEXT,
	ContractId SERIAL,
	FOREIGN KEY (ContractId) REFERENCES Contracts(ContractId)
);

CREATE TABLE IF NOT EXISTS ObjectPlans (
	PlanId SERIAL PRIMARY KEY,
	ContractId SERIAL,
	FileId SERIAL,
	FOREIGN KEY (ContractId) REFERENCES Contracts(ContractId),
	FOREIGN KEY (FileId) REFERENCES Files(FileId)
);

CREATE TABLE IF NOT EXISTS ObjectPhotos (
	PhotoId SERIAL PRIMARY KEY,
	ContractId SERIAL,
	ImageId SERIAL,
	FOREIGN KEY (ContractId) REFERENCES Contracts(ContractId),
	FOREIGN KEY (ImageId) REFERENCES Images(ImageId)
);