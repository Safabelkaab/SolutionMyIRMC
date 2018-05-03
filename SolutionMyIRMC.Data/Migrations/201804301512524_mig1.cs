namespace SolutionMyIRMC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CommentEvent",
                c => new
                {
                    idComment = c.Int(nullable: false, identity: true),
                    textComment = c.String(unicode: false),
                    idTopic_fk = c.Int(),
                })
                    
                .PrimaryKey(t => t.idComment)
                .ForeignKey("dbo.TopicEvent", t => t.idTopic_fk)
                .Index(t => t.idTopic_fk);
            
            CreateTable(
                "dbo.TopicEvent",
                c => new
                    {
                        idTopic = c.Int(nullable: false, identity: true),
                        textTopic = c.String(unicode: false),
                        categoryTopic = c.String(unicode: false),
                        idEvent_fk = c.Int(),
                    })
                .PrimaryKey(t => t.idTopic)
                .ForeignKey("dbo.Event", t => t.idEvent_fk)
                .Index(t => t.idEvent_fk);
            
            CreateTable(
                "dbo.Event",
                c => new
                    {
                        idEvent = c.Int(nullable: false, identity: true),
                        titreEvent = c.String(unicode: false),
                        descriptionEvent = c.String(unicode: false),
                        lieuxEvent = c.String(unicode: false),
                        dateEvent = c.DateTime(precision: 0),
                        contactEvent = c.String(unicode: false),
                        telEvent = c.String(unicode: false),
                        image = c.String(unicode: false),
                        commentaireEvent = c.String(unicode: false),
                        validation = c.Boolean(nullable: false),
                        category_id = c.Int(),
                        marker_id = c.Int(),
                        user_idUser = c.Int(),
                    })
                .PrimaryKey(t => t.idEvent)
                .ForeignKey("dbo.Category", t => t.category_id)
                .ForeignKey("dbo.Marker", t => t.marker_id)
                .ForeignKey("dbo.User", t => t.user_idUser)
                .Index(t => t.category_id)
                .Index(t => t.marker_id)
                .Index(t => t.user_idUser);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.EvaluationEvent",
                c => new
                    {
                        idEvalEvent = c.Int(nullable: false),
                        nomEvent = c.String(unicode: false),
                        nbPartcipant = c.Int(nullable: false),
                        valeurGlobale = c.String(unicode: false),
                        serviceGlobal = c.String(unicode: false),
                        instalaltionGlobale = c.String(unicode: false),
                        recommandation = c.String(unicode: false),
                        idEvent_fk = c.Int(),
                    })
                .PrimaryKey(t => t.idEvalEvent)
                .ForeignKey("dbo.Event", t => t.idEvent_fk)
                .Index(t => t.idEvent_fk);
            
            CreateTable(
                "dbo.Marker",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(unicode: false),
                        address = c.String(unicode: false),
                        lng = c.Double(nullable: false),
                        lat = c.Double(nullable: false),
                        type = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        idUser = c.Int(nullable: false, identity: true),
                        nom = c.String(unicode: false),
                        prenom = c.String(unicode: false),
                        role = c.String(unicode: false),
                        password = c.String(unicode: false),
                        email = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.idUser);
            
            CreateTable(
                "dbo.EvaluationTender",
                c => new
                    {
                        IdEvalTender = c.Int(nullable: false, identity: true),
                        nbTenderReceived = c.Int(nullable: false),
                        interetTender = c.String(unicode: false),
                        prixRaisonable = c.String(unicode: false),
                        note = c.Int(nullable: false),
                        recommandation = c.String(unicode: false),
                        idTender_fk = c.Int(),
                    })
                .PrimaryKey(t => t.IdEvalTender)
                .ForeignKey("dbo.Tender", t => t.idTender_fk)
                .Index(t => t.idTender_fk);
            
            CreateTable(
                "dbo.Tender",
                c => new
                    {
                        idTender = c.Int(nullable: false, identity: true),
                        titleTender = c.String(unicode: false),
                        description = c.String(unicode: false),
                        contact = c.String(unicode: false),
                        sourceInformation = c.String(unicode: false),
                        category_id = c.Int(),
                        marker_id = c.Int(),
                    })
                .PrimaryKey(t => t.idTender)
                .ForeignKey("dbo.Category", t => t.category_id)
                .ForeignKey("dbo.Marker", t => t.marker_id)
                .Index(t => t.category_id)
                .Index(t => t.marker_id);
            
        }
        
        public override void Down()
        {
          
        }
    }
}
