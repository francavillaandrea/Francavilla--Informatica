#define MAX_LENGHT 100
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct{
    char nome [MAX_LENGHT];
    char data [MAX_LENGHT];
    int peso;
    int altezza;

} Patient;

typedef struct{
    char nomePaziente [MAX_LENGHT];
    char nomeMedico [MAX_LENGHT];
    char data [MAX_LENGHT];
    char ora [MAX_LENGHT];
}ScheduledVisit;

int getCurrentPatientsCount();
int printPatients();
int addNewPPatients();
int addNewScheduledVisit(ScheduledVisit visit);
int printPatientVisits(char patientName[MAX_LENGHT]);


int createMenù{
    int choice;
    printf("1 - Print current patient count\n2 - Print patient\n3 - Add new patient\n4 - Add new visit to schedule\n5 - Print patient scheduled visits\n");
    scanf("%d", &choice);
    return choice
}

int doOperation(int choice)
{
    Patient paziente;
    ScheduledVisit visit;
    int count;
    switch (choice)
    {
        case 1:
            count = getCurrentPatientsCount();
            break;
        case 2:
            printPatients();
            break;
        case 3:
            printf("Inserire i dati del paziente da aggiungere: \n");
            scanf("%s %s %d  %d", paziente.nome, paziente.data, &paziente.peso, &paziente.altezza);ù
            addNewPPatients(patient);
            break;
        case 4:
            printf("Inserisci i dati della visita: \n");
            scanf("%s %s %s %s ", visit.nomePaziente, visit.nomeMedico, visit.data, visit.ora);
            addNewScheduledVisit(visit);
            break;
        case 5:
            printf("Inserisci il nome del paziente: ");
            scanf("%s", paziente.nome);
            printPatientVisits(paziente.nome);
            break;
        default:
            printf("Invalid choice \n");

    }
    return 0;
}

int getCurrentPatientsCount()
{
    int count  = 0;
    FILE *fp = fopen("./patients.txt", "r");
    if(fp == NULL)
    {
        return -1;
    }
    while(!feof(fp))
    {
        patient p;
        fscanf(fp, "%s %s %d %d ", p.nome, p.data, &p.peso, &p.altezza);
        count++;
    }
    fclose(fp);
    return count;
}

int printPatients(){
    Patient patient;
    FILE *fp = fopen("./patients.txt", "r");
    if(fp == NULL)
    {
        return -1;
    }
    while(fscanf(fp, "%s %s %d %d ", patient.nome, patient.data, &patient.peso, &patient.altezza));
    {
        printf("%s - %s - %d Kg - %d Cm\n", patient.nome, patient.data, &patient.peso, &patient.altezza);
    }
    fclose(fp);
    return 0;
}

int addNewPPatients(Patient patient){
    FILE *fp = fopen("./patients.txt", "a");
    if (fp = NULL)
    {
        return -1;
    }
    fprintf(fp, "%s %s %d %d\n", patient.nome, patient.data, patient.peso, patient.altezza );
    fclose(fp);
    return 0;
}

int addNewScheduledVisit(ScheduledVisit visit)
{
    FILE *fp = fopen("./patients.txt", "a");
    if (fp = NULL)
    {
        return -1;
    }
    fprintf(fp, "%s %s %s %s\n", visit.nomePaziente, visit.nomeMedico, visit.data, visit.ora );
    fclose(fp);
    return 0;
}

int printPatientVisits(char patientName[MAX_LENGHT])
{
    ScheduledVisit visit;
    FILE *fp = fopen("./patients.txt", "a");
    if (fp = NULL)
    {
        return -1;
    }
    while(fscanf(fp, "%s %s %s %s \n", visit.nomePaziente, visit.nomeMedico, visit.data, visit.ora)!= EOF)
    {
        if(strcmp(visit.nomePaziente, patientName) == 0)
        {
            printf("%s - %s - %s -%s \n", visit.nomePaziente, visit.nomeMedico, visit.data, visit.ora);
        }
    }
    fclose(fp);
    return 0;
}