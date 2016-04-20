function stat=fqlearn(stat)
%% fuzzy q-learning
% ------------------------------------------------------------------------
% Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
% The code is released under the FreeBSD License.
% Copyright (C) 2016 Pooyan Jamshidi, Imperial College London
% The scripts implement Fuzzy Q-learning algorithm
% ------------------------------------------------------------------------


global NS FIS

% determine the number of antecedents of the rules in the knowledge base of
% the fuzzy logic controller
number_of_input=size(FIS.input,2);

% initialize the activation function or degree of truth of the rules in the
% knowledge base, again number of rules is equal to number of states in MDP
alpha=ones(NS,1);

% incrementing the learning iteration
stat.iter=stat.iter+1;

%% Setting the step-size to determine how fast learning takes place: learning rate

% 1/k
%learn_rate=1/(stat.iter);

% log(k)/k
%learn_rate=log(stat.iter+1)/(stat.iter+1);

% a/(b+k)
%learn_rate=0.5*300/(300+stat.iter);

% constant learning rate
learn_rate=0.1;

%% Value iteration update rule

for i=1:NS
    
    for j=1:number_of_input % number of antecedents
        
        % if the antecedent MF exists in the associated rule
        if FIS.rule(i).antecedent(j)>0
            %calculate the activation function
            alpha(i)=alpha(i)*evalmf(stat.current_state(j),FIS.input(j).mf(FIS.rule(i).antecedent(j)).params,FIS.input(j).mf(FIS.rule(i).antecedent(j)).type);
        end
        
    end

    ai=fuzzy_action_selector(stat,i);
    stat.Q(i,ai)=stat.Q(i,ai)+learn_rate*error_signal_calculator(stat)*alpha(i);
    
end
