function [Q,LEARN]=fqlearn(Q,current_state,next_state,ais)
%% This function implements Fuzzy Q-Learning
% Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)

%% initializations
globalfql % global parameters initialized

global NS NA FIS

% determine the number of antecedents of the rules in the knowledge base of
% the fuzzy logic controller
number_of_input=size(FIS.input,2);

% initialize the activation function or degree of truth of the rules in the
% knowledge base, again number of rules is equal to number of states in MDP
alpha=ones(NS,1);

% initialize the matrix that maintain the number of updates for each
% q-value corresponding to Q lookup table
LEARN=zeros(NS,NA);
%% Setting the step-size to determine how fast learning takes place: learning rate

% 1/k
%learn_rate=1/(stat.iter);

% log(k)/k
%learn_rate=log(stat.iter+1)/(stat.iter+1);

% a/(b+k)
%learn_rate=0.5*300/(300+stat.iter);

% constant learning rate
learn_rate=0.1;

%% Value iteration update rule (learning process)

for i=1:NS
    
    for j=1:number_of_input % number of antecedents
        
        % if the antecedent MF exists in the associated rule
        if FIS.rule(i).antecedent(j)>0
            %calculate the activation function
            alpha(i)=alpha(i)*evalmf(current_state(j),FIS.input(j).mf(FIS.rule(i).antecedent(j)).params,FIS.input(j).mf(FIS.rule(i).antecedent(j)).type);
        end
        
    end
    
    ai=ais(i); % select an action (for each activated rule!)
    if alpha(i)~=0
        % update Q table
        Q(i,ai)=Q(i,ai)+learn_rate*error_signal_calculator(Q,current_state,next_state,ais)*alpha(i); % update q-values by an ordinary gradient descent method
        % update the stats for maintaining the number of updates of the
        % q-values
        LEARN(i,ai)=LEARN(i,ai)+1;
    end
end
end
