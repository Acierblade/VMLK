using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class vSubtitles : MonoBehaviour {

    public Text text;
    public AudioSource audioSource;
    public bool show;
    public Rigidbody book;
    public Renderer bookCover;
    public Material[] bookmaterials;



    // Use this for initialization
    void Start ()
    {

        if (text == null)
        {
            text = GetComponent<Text>();
        }

        if (book == null)
        { 
        book = GetComponent<Rigidbody>();
        }

        if (bookCover == null)
        {
            bookCover = GetComponent<Renderer>();
        }
    }

    private void Show()
    {
        if (book.isKinematic == true)
        {
            show = true;
            bookCover.material = bookmaterials[0];
        }

        else
        {
            show = false;
            bookCover.material = bookmaterials[1];


        }
    }
	
	// Update is called once per frame
	void Update () {

        //Showing the current audio time in console
        //Debug.Log(audioSource.time);
        Show();


        if (show)
        {
            text.color = new Color(0, 0, 0, 255);
        }

        else
        {
            text.color = new Color (255, 255, 255, 0);
        }

        //Showing subtitles based on audio time. Use Time.time to base it on time since game started.
        if (audioSource.time > 1.4f && audioSource.time < 29.52f)
        {
            text.text = "Victor Hugo once said that there is nothing in all the world more powerful than an idea whose time has come. " +
                "The dynamic idea whose time has come today is the quest for freedom and human dignity.";
        }


        else if (audioSource.time > 29.52f && audioSource.time < 49.38f)
        {
            text.text = "Men are tired of being trampled over by the iron feet of oppression. " +
                "They are tired of being plunged into the abyss of exploitation where they experience the bleakness of nagging despair.";
        }


        else if (audioSource.time > 49.38f && audioSource.time < 72.57f)
        {
            text.text = "So all over the world formerly oppressed people are making it palpably clear that they are determined to be free. " +
                "You students of North Carolina have captured this dynamic idea in a marvelous manner.";
        }

        else if (audioSource.time > 72.57f && audioSource.time < 89.29f)
        {
            text.text = "You have taken the undying and passionate yearning for freedom and filtered it in your own soul " +
                "and fashioned it into a creative protest that is destined to be one of the glowing epics of our time.";
        }


        else if (audioSource.time > 89.29f && audioSource.time < 111.54f)
        {
            text.text = "For the past few days, you have moved in a uniquely, meaningful orbit imparting heat and light to distant satellites. " +
                "In this period when civil rights legislation hangs in an uncertain balance in the congress—";
        }


        else if (audioSource.time > 111.54f && audioSource.time < 128.85f)
        {
            text.text = "when the recalcitrance of some public officials in the South instills us with " +
                "frustration and despondency, the spectacular example of determined and dedicated young people demanding their rights";
        }

        else if (audioSource.time > 128.85f && audioSource.time < 147.93f)
        {
            text.text = "gives glorious inspiration to all decent persons to all decent persons not only of our nation, but throughout the world. " +
                "You have taken hold of the tradition of resolute non-violent resistance";
        }


        else if (audioSource.time > 147.93f && audioSource.time < 164.95f)
        {
            text.text = "and you are carrying it forward toward the end of bringing all of us closer to the day of full freedom. " +
                "In my recent travels in Africa and Asia, I was struck by the youthfulness of the leaders";
        }

        else if (audioSource.time > 164.95f && audioSource.time < 185.46)
        {
            text.text = "in the struggle for liberation and by the immensely responsible role of students. What is fresh, what is new " +
                "in your fight is the fact that it was initiated, fed and sustained by students.";
        }

        else if (audioSource.time > 185.46f && audioSource.time < 203.18f)
        {
            text.text = "What is new is that American students have come of age. " +
                "You now take your honored places and you are able to create a creative protest " +
                "against segregated eating facilities again ";
        }

        else if (audioSource.time > 203.18f && audioSource.time < 218.16f)
        {
            text.text = "highlights the fact that segregation is the Negro’s burden and America’s shame.";
        }

        else if (audioSource.time > 218.16f && audioSource.time < 242.94f)
        {
            text.text = "You have given an additional death blow to the once prevalent idea " +
                "that the Negro prefers segregation. You have also made it clear that we will not be satisfied with token integration,";
        }

        else if (audioSource.time > 242.94f && audioSource.time < 266.04f)
        {
            text.text = "for token integration is nothing but a new form of discrimination covered up with certain niceties of complexity. " +
                "Separate facilities, whether in eating places or public schools, are inherently unequal.";
        }

        else if (audioSource.time > 266.04f && audioSource.time < 283.67f)
        {
            text.text = "The underlying philosophies of segregation are diametrically opposed to democracy and Christianity, and all the " +
                "dialectics of all the logicians of the world cannot make them lie down together.";
        }

        else if (audioSource.time > 283.67f && audioSource.time < 300.96f)
        {
            text.text = "So, I would call upon all of the people of goodwill in this community to support the efforts of these students. " +
                "I would also call upon the white people of this State to back-up the marvelous protest of these students.";
        }

        else if (audioSource.time > 300.96f && audioSource.time < 317.23f)
        {
            text.text = "What they are doing is significant not only for North Carolina, not only for the Negro, " +
                "but for the whole of America.";
        }

        else if (audioSource.time > 317.23f && audioSource.time < 335.21f)
        {
            text.text = "I’m convinced more white people must join the movement against segregation in this country. " +
                "The tensions in race relations in the United States today are not tensions between white and black people; ";
        }

        else if (audioSource.time > 335.21f && audioSource.time < 368.81f)
        {
            text.text = "they are tensions between justice and injustice, between light and darkness. If there is a victory, " +
                "it will not be for just seventeen million Negroes; it will be a victory for justice, democracy and freedom.";
        }

        else if (audioSource.time > 368.81f && audioSource.time < 389.70f)
        {
            text.text = "The festering sore of segregation debilitates the white man as well as the Negro. So long as America is " +
                "burdened down with the ugly weight of segregation, she cannot expect to have the respect of the peoples of the world.";
        }

        else if (audioSource.time > 389.70f && audioSource.time < 414.96f)
        {
            text.text = "Indeed the shape of the world today does not permit us the luxury of an anemic democracy. America must either " +
                "achieve racial justice or face the ultimate social psychosis that can lead to domestic suicide.";
        }

        else if (audioSource.time > 414.96f && audioSource.time < 432.51f)
        {
            text.text = "May I say to you as you continue your protest, you will confront moments of difficulty. But let us realize that no " +
                "great and lasting gain comes in history without suffering and sacrifice.";
        }

        else if (audioSource.time > 432.51f && audioSource.time < 457.55f)
        {
            text.text = "I have prayed much over our Southern situation, and I have come to the conclusion that we are in for a season of suffering. " +
                "Now I pray that, recognizing the necessity of suffering, the Negro will make of it a virtue.";
        }

        else if (audioSource.time > 457.55f && audioSource.time < 486.52f)
        {
            text.text = "To suffer in a righteous cause is to grow to our humanity’s full stature. If only to save ourselves from bitterness, " +
                "we need the vision to see the ordeals of this generation as an opportunity to transfigure ourselves and American society.";
        }

        else if (audioSource.time > 486.52f && audioSource.time < 513.07f)
        {
            text.text = "Let us not fear going to jail. If the officials threaten to arrest us for standing up for our rights, we must answer by " +
                "saying that we are willing and prepared to fill up the jails of the South.";
        }

        else if (audioSource.time > 513.07f && audioSource.time < 522.79f)
        {
            text.text = "Maybe it will take this willingness to stay in jail to arouse the dozing conscience of our nation.";
        }

        else if (audioSource.time > 522.79f && audioSource.time < 535.18f)
        {
            text.text = "May I also urge you to continue the struggle on the highest level of dignity. You have rightly chosen " +
                "to follow the path of non-violence.";
        }

        else if (audioSource.time > 535.18f && audioSource.time < 556.50f)
        {
            text.text = "As we protest, our ultimate aim is not to defeat or humiliate the white man but to win his friendship and understanding. " +
                "We have a moral obligation to remind him that segregation is wrong.";
        }

        else if (audioSource.time > 556.50f && audioSource.time < 578.97f)
        {
            text.text = "Let us protest with the ultimate aim of being reconciled with our white brothers. As we sit down quietly to request a cup of coffee, " +
                "let us not forget to drink from that invisible cup of love, ";
        }

        else if (audioSource.time > 578.97f && audioSource.time < 595.94f)
        {
            text.text = "which can change a segregationist into an integrationist. Let us keep our eyes on the end we seek, but let us never forget the " +
                "significance of proper means.";
        }

        else if (audioSource.time > 595.94f && audioSource.time < 611.14f)
        {
            text.text = "There is a success of history and a success of eternity. Right methods to achieve a right objective is " +
                "itself a coming together of history and eternity, ";
        }

        else if (audioSource.time > 611.14f && audioSource.time < 631.61f)
        {
            text.text = "and where one uses right methods there is, even if obscured in history, a spiritual victory. Let us avoid not only external physical " +
                "violence but also internal violence of the spirit.";
        }

        else if (audioSource.time > 631.61f && audioSource.time < 651.98f)
        {
            text.text = "We can build an empire depending on Love. In that way, we may be able to not only teach ourselves something, " +
                "but we may be able also to teach others something.";
        }

        else if (audioSource.time > 651.98f && audioSource.time < 665.43f)
        {
            text.text = "The choice is no longer between violence and non-violence; it is between violence and non-existence. All the darkness in the world " +
                "cannot obscure the light of a single candle.";
        }

        else if (audioSource.time > 665.43f && audioSource.time < 686.05f)
        {
            text.text = "And so I would urge you to continue your just struggle until the people with whom you trade will respect your person as much as " +
                "they respect your dollar.";
        }

        else if (audioSource.time > 686.05f && audioSource.time < 705.86f)
        {
            text.text = "May I assure you that you have the full weight of the Southern Christian Leadership Conference behind you in your struggle. At a certain " +
                "point in every struggle of great importance, a moment of doubt or hesitation develops.";
        }

        else if (audioSource.time > 705.86f && audioSource.time < 728.72f)
        {
            text.text = "Some voices declare, “Let us stop here, we have gone far enough.” We confronted this crisis in Montgomery—we had these doubts. Despite the debates, " +
                "the confusion and the uncertainty we carried on.";
        }

        else if (audioSource.time > 728.72f && audioSource.time < 736.81f)
        {
            text.text = "If there is one lesson experience taught us which I would hope to leave with you, ";
        }

        else if (audioSource.time > 736.81f && audioSource.time < 766.43f)
        {
            text.text = "it is that when you have found by the help of God a correct course, " +
                "a morally sound objective, you do not equivocate, you do not retreat, you struggle to win a victory.";
        }

        else if (audioSource.time > 766.43f && audioSource.time < 782.57f)
        {
            text.text = "Let nobody stop you; you are doing something that will ultimately save the soul of America. " +
                "If you continue to struggle, there will be a new day in America.";
        }

        else if (audioSource.time > 766.43f && audioSource.time < 796.90f)
        {
            text.text = "We’re not rabble rousers; we’re not dangerous agitators, nor do we seek political dominance. " +
                "Black supremacy is as bad as white supremacy.";
        }

        else if (audioSource.time > 796.90f && audioSource.time < 817.19f)
        {
            text.text = "But freedom is necessary for one’s selfhood, for one’s intrinsic worth. Let us say to the white people, " +
                "we’re not going to take bombs into your communities. We will not do anything to destroy you physically.";
        }

        else if (audioSource.time > 817.19f && audioSource.time < 844.95f)
        {
            text.text = "We will not turn to some foreign ideology. Communism has never invaded our ranks. We’ve been loyal to America. " +
                "Now we want to be free.";
        }

        else if (audioSource.time > 844.95f && audioSource.time < 862.81f)
        {
            text.text = "And remember that both history and destiny are on your side. All the stars in their course are supporting you. " +
                "Go out with the attitude that God is with us and we have cosmic companionship.";
        }

        else if (audioSource.time > 862.81f && audioSource.time < 893.31f)
        {
            text.text = "And one day, historians of this era might be able to say, there lived a great people, " +
                "a black people who injected new meaning into civilization.";
        }

        else
        {
            text.text = null;
        }
    }
}
