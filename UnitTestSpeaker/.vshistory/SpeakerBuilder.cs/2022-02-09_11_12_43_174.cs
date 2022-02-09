﻿using System;
namespace UnitTestSpeaker;

    public class SpeakerBuilder
{
    private Name name = new Name("Jan", "B");
    private Address address =
        new Address("PL", "00-002", "Warsaw", "Lemonowa 12");
    private DateTime birthDate = AppTime.Now().AddYears(-25);

    private SpeakerWebsites speakerWebsites =
        SpeakerWebsitesBuilder.GivenSpeakerWebsites().Build();

    private Contact contact = new Contact("655-555-555", "C@gmail.com");

    private string Bio = "asasa";

    public static SpeakerBuilder GivenSpeaker() => new SpeakerBuilder();

    public SpeakerBuilder WithAge(int age)
    {
        this.birthDate = AppTime.Now().AddYears(-1 * age);
        return this;
    }

    public SpeakerBuilder BornOn(DateTime birthDate)
    {
        this.birthDate = birthDate;
        return this;
    }

    public SpeakerBuilder WithNullBirthDate()
    {
        this.birthDate = default;
        return this;
    }

    public SpeakerBuilder WithContact(string Phone, string email)
    {
        this.contact = new Contact(Phone, email);
        return this;
    }

    public SpeakerBuilder WithNullContact()
    {
        this.contact = null;
        return this;
    }

    public SpeakerBuilder WithNullName()
    {
        this.name = null;
        return this;
    }

    public SpeakerBuilder WithAddress(string country, string zip, string city, string street)
    {
        this.address = new Address(country, zip, city, street);
        return this;
    }

    public SpeakerBuilder WithNullAddress()
    {
        this.address = null;
        return this;
    }

    public SpeakerBuilder WithSpeakerWebsites(
        Action<SpeakerWebsitesBuilder> speakerBuilderAction)
    {
        var speakerWebsiteBuilder = new SpeakerWebsitesBuilder();
        speakerBuilderAction(speakerWebsiteBuilder);
        speakerWebsites = speakerWebsiteBuilder.Build();
        return this;
    }

    public SpeakerBuilder WithSpeakerWebsites(
        SpeakerWebsites speakerWebSites)
    {
        speakerWebsites = speakerWebSites;
        return this;
    }

    public SpeakerBuilder WithNullSpeakerWebsites()
    {
        speakerWebsites = null;
        return this;
    }

    public Speaker Build()
    {
        return new Speaker
        (
            name,
            birthDate,
            address,
            speakerWebsites,
            Bio,
            contact
        );
    }

}
