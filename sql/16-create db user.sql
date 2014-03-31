USE [grantapp]
GO

CREATE LOGIN grantuser WITH PASSWORD = 'pw,1,LVCV';
CREATE USER grantuser FOR LOGIN grantuser;

GRANT ALL ON approach TO grantuser;
GRANT ALL ON changelog TO grantuser;
GRANT ALL ON contact_history TO grantuser;
GRANT ALL ON documentation_requirement TO grantuser;
GRANT ALL ON documentation_type TO grantuser;
GRANT ALL ON [grant] TO grantuser;
GRANT ALL ON grant_program TO grantuser;
GRANT ALL ON grant_project TO grantuser;
GRANT ALL ON grantor TO grantuser;
GRANT ALL ON program TO grantuser;
GRANT ALL ON project TO grantuser;
GRANT ALL ON [state] TO grantuser;
GRANT ALL ON status_type TO grantuser;
GRANT ALL ON [user] TO grantuser;